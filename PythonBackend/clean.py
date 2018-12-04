def clean(text: str, keep_sections=True):
    text = text.strip().split("\n")
    if keep_sections:
        text = [x.strip() for x in text]
        text = "\n".join(text)
        for x in range(20, 2, -1):  # Max no. of "\n"s
            text = text.replace("\n" * x, "\n")
        text.replace("\n\n", "\t")
        text.replace("\n", "")
        text.replace("\t", "\n")
    else:
        text = [x.strip() for x in text if x.strip() != ""]
        text = "\n".join(text)
    return text


def simple_extractor(text: str, search: str):
    search = search.lower()
    text2 = text.lower()
    if search in text2:  # We are assuming only 1 occurrence of `search` in text
        index = text2.find(search)
        end = text2.find("\n", index)
        return text[index:end]
    else:
        return "NOT FOUND"


if __name__ == '__main__':
    txt = """901

 

 

 

 

 

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

MCPIFDW/8 December 2017/LC1819075/CWP

 

 

‘ABCSL Auth:
mep

 

 

 

ABCSL Auth =

i WOH

oO"""

    a = clean(txt)
    print(a)
    # print(simple_extractor(a, "Auth"))
