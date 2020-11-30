import nltk
import re
from nltk.corpus import stopwords
from nltk.tokenize import word_tokenize
import math
import codecs

"""In this project, the goal is to identify a set of Stopwords in Corpus Hamshahri.
   In fact, despite the many repetitions in the text, stopwords are semantically of
   little importance for this purpose It is very important to identify them"""

doc = 0
docs = []


def remove_string_special_characters_strip(text):
    stripped = re.sub(r"\d", "", text)
    stripped = re.sub('[^\w\s]', '', stripped)
    stripped = stripped.replace("Cat", "#")
    stripped = re.sub(r"[a-z]", "", stripped, flags=re.I)
    stripped = re.sub(r"\s+", " ", stripped, flags=re.I)

    return stripped


def get_doc(doc):
    i = 0
    doc_info = []
    for doc in docs:
        count = count_words(doc)
        temp = {'doc_id': i, 'doc_length': count}
        doc_info.append(temp)
    return doc_info


def count_words(doc):
    """ this function returns the total number of words """
    count = 0
    words = word_tokenize(doc)
    count = len(words)
    return count


def create_freq_dict(docs):
    i = 0
    freq_list = []
    for doc in docs:
        i += 1
        freq_dict = {}
        words = word_tokenize(doc)
        for word in words:
            word = word.lower()
            if word in freq_dict:
                freq_dict[word] += 1
            else:
                freq_dict[word] = 1
            temp = {'doc_id': i, 'freq_dict': freq_dict}
        freq_list.append(temp)
    return freq_list


def computeTF(doc_info, freq_list):
    TF_scores = []
    for tempDict in freq_list:
        id = tempDict['doc_id']
        for k in tempDict['freq_dict']:
            temp = {'doc_id': id,
                    'TF_score': (1 + math.log(tempDict['freq_dict'][k])),
                    'key': k}
            TF_scores.append(temp)
    return TF_scores


def computeIDF(doc_info, freq_list):
    IDF_scores = []
    counter = 0
    for dict in freq_list:
        counter += 1
        for k in dict['freq_dict'].keys():
            count = sum([k in tempDict['freq_dict'] for tempDict in freq_list])
            temp = {'doc_id': counter, 'IDF_score': math.log(
                len(doc_info)/count), 'key': k}
            IDF_scores.append(temp)
    return IDF_scores


def computeTFIDF(TF_scores, IDF_scores):
    TFIDF_scores = []
    for j in IDF_scores:
        for i in TF_scores:
            if j['key'] == i['key'] and j['doc_id'] == i['doc_id']:
                temp = {'doc_id': j['doc_id'],
                        'TFIDF_scores': j['IDF_score']*i['TF_score'],
                        'key': i['key']}
                if temp.get('TFIDF_scores') >= 1.92:
                    TFIDF_scores.append(temp)
    return TFIDF_scores


with codecs.open("C:\\Users\\Asus\\Desktop\\Project4\\Hamshahri-Corpus\\New Text Document.txt", 'r', encoding="utf-8") as text:
    context = text.read()
    context = remove_string_special_characters_strip(context)
    docs = context.split("#")
    docs.pop(0)
doc_info = get_doc(doc)
freq_list = create_freq_dict(docs)
TF_scores = computeTF(doc_info, freq_list)
IDF_scores = computeIDF(doc_info, freq_list)
TFIDF_scores = computeTFIDF(TF_scores, IDF_scores)
print(TFIDF_scores)
