from gensim.models import KeyedVectors
from sklearn.feature_extraction.text import TfidfVectorizer
from sklearn.metrics.pairwise import cosine_similarity
import numpy as np


def clean(q):
    words = q.split()
    # remove punctuation from each word
    import string
    table = str.maketrans('', '', string.punctuation)
    stripped = [w.translate(table).lower() for w in words]
    return stripped


def calculate_doc_vectors(q):
    # load the stanford glove model
    filename = 'glove.6B.100d.txt.word2vec'
    model = KeyedVectors.load_word2vec_format(filename, binary=False)

    # Testing
    # q=['if the. If the.']
    q[0] = clean(q[0])
    w_vectors = []
    for i in q[0].split(' '):
        try:
            w_vectors.append(model[i])
        except Exception as e:
            pass
    cv = TfidfVectorizer()
    # Calc tfidf
    datasetTFIDF = cv.fit_transform(q)
    vocab_of_q = (cv.vocabulary_)
    weights = []
    for i in q[0].split(' '):
        weights.append(vocab_of_q[i])
    docvec = np.average(w_vectors, axis=0, weights=weights)
    return (docvec)
