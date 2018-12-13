import sys


def test_print(*args, **kwargs):
    print(*args, file=sys.stderr, **kwargs)


def get(txt: list, field: str) -> str:
    maybe = "---"
    test_print(len(txt))
    for text in txt:
        test_print("Page index=", txt.index(text))
        test_print(text)
        text2 = text
        text2 = text2.strip().split("\n")
        text2 = [tt.strip() for tt in text2]
        for i in range(len(text2)):
            # test_print(text2[i])
            if text2[i].lower().startswith(field.lower().split(' ')[0]):
                # test_print(text2[i])
                text3 = " ".join([tt for tt in text2[i:] if tt != ""])
                # test_print(text3)
                if text3.lower().startswith(field.lower()):
                    # test_print(text3)
                    try:
                        first_colon = text3.index(":")
                        first = 0
                        for j in range(i, len(text2)):
                            try:
                                if text2[j].index(":") != -1:
                                    if first == 0:  # field split over multiple lines
                                        # test_print(text2[j])
                                        first = 1
                                    elif first == 1:
                                        # TODO: Extra is better than less, isn't it??
                                        # test_print(text2[j])
                                        content = [t for t in text2[i:j]]
                                        ans = " ".join(content)
                                        ans = ans[ans.index(":") + 1:].strip()
                                        return ans
                            except ValueError:
                                pass
                        return text3[first_colon + 1:].strip()
                    except ValueError:
                        # TODO What if it is not exactly a key value pair??
                        for j in range(i, len(text2)):
                            try:
                                if text2[j].index(":") != -1:
                                    # TODO: Extra is better than less, isn't it??
                                    content = [t for t in text2[i:j]]
                                    ans = " ".join(content)
                                    maybe = ans[ans.index(":") + 1:].strip()
                            except ValueError:
                                pass
    return maybe


def get_content(txt, fields):
    answer = {}
    if isinstance(txt, str):
        test_print("Was a string")
        txt = [txt]
    if isinstance(txt, list):
        for field in fields:
            test_print("Field", field)
            value = get(txt, field)
            value = " ".join([p for p in value.split(" ") if p != ""])
            # test_print(value)
            for field1 in fields:
                if field1 != field:
                    try:
                        ind = value.lower().index(field1.lower())
                        value = value[:ind].strip()
                        break
                    except ValueError:
                        pass
            test_print(value)
            answer[field] = value
    return answer


if __name__ == '__main__':
    _txt = """901
B0902DC1812345000 ABC
Page 1 of 24
RISK DETAILS

Unique Market

Reference: B0902DC1812345000

Attaching To

Delegated

Underwriting

Contract

Number: Attaching Lloyd & Partners Master Contract No .

Type: Marine Cargo Excess Insurance.

Insured: GHIJK Limited and/or Associated and/or Affiliated and/or Interrelated

and/or Subsidiary Companies and/or Corporations as they now are or
may hereafter be created and/or constituted and/or for whom the
Insured receive instructions to insure and/or for whom the Insured have
or assume a responsibility to arrange insurance, whether contractually
or otherwise, as their respective rights and interests may appear
hereinafter known as the Insured.
Loss Payee: In accordance with the Insured's business requirements
itis agreed that Banks and/or mortgagees and/or lenders and/or similar
interested parties are to be automatically included as Loss Payees
herein as their respective rights and interests may appear in the
subject-matter insured but only in so far as losses may be recoverable
under the terms and conditions agreed herein. Details of such loss
payee interests to be advised to and retained in the files of ABC
Specialty Limited.

Address of the

Insured: 351 East Avenue
Pomona
Illinious
85201
United States of America

Period: 5 May 2017 at 00:01 hours Local Standard Time at the “Address of the
Insured” herein until 5 May 2018 at 00:01 hours Local Standard Time at
the “Address of the Insured” herein.

It is agreed that notwithstanding anything contained herein to the
contrary that cover hereunder may be extended for up to three months,
if required, subject to the agreement of the Slip Leader only.
MCP/FDW/8 December 2017/LC1819075/CWP_
ABCSL Auth:
mep
(MLA
70210473014"""
    keys = ["Address of the insured", "type", "insured", "period", "unique market reference", "Attaching to "]
    # keys = ["Attaching to "]
    a = get_content(_txt, keys)
    for x in a:
        test_print(x, "-", a[x])
