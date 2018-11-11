import spacy
spacy_nlp = spacy.load('en')


def entity_recognition(q, entity):
    document = spacy_nlp(q)

    for element in document.ents:
        if element.label_.lower() == entity.lower():
            print('Value: %s' % element)
