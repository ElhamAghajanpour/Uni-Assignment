import math
import codecs
import re
import numpy as np
from hazm import Normalizer

"""Investigating the effect of the word physician and medicine on two types of sports and medical corpus"""

normalizer = Normalizer()
text1 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Medical_Files\\text1.txt", "r", encoding="utf-8").read())
text2 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Medical_Files\\text2.txt", "r", encoding="utf-8").read())
text3 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Medical_Files\\text3.txt", "r", encoding="utf-8").read())
text4 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Medical_Files\\text4.txt", "r", encoding="utf-8").read())
text5 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Medical_Files\\text5.txt", "r", encoding="utf-8").read())
text6 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Medical_Files\\text6.txt", "r", encoding="utf-8").read())
text7 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Medical_Files\\text7.txt", "r", encoding="utf-8").read())
text8 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Medical_Files\\text8.txt", "r", encoding="utf-8").read())
text9 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Medical_Files\\text9.txt", "r", encoding="utf-8").read())
text10 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Medical_Files\\text10.txt", "r", encoding="utf-8").read())
text11 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Sports_Files\\text11.txt", "r", encoding="utf-8").read())
text12 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Sports_Files\\text12.txt", "r", encoding="utf-8").read())
text13 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Sports_Files\\text13.txt", "r", encoding="utf-8").read())
text14 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Sports_Files\\text14.txt", "r", encoding="utf-8").read())
text15 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Sports_Files\\text15.txt", "r", encoding="utf-8").read())
text16 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Sports_Files\\text16.txt", "r", encoding="utf-8").read())
text17 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Sports_Files\\text17.txt", "r", encoding="utf-8").read())
text18 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Sports_Files\\text18.txt", "r", encoding="utf-8").read())
text19 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Sports_Files\\text19.txt", "r", encoding="utf-8").read())
text20 = normalizer.normalize(codecs.open(
    "C:\\Users\\Asus\\Desktop\\Project2\\Sports_Files\\text20.txt", "r", encoding="utf-8").read())

Medical_text = [text1, text2, text3, text4,
                text5, text6, text7, text8, text9, text10]
Sport_text = [text11, text12, text13, text14,
              text15, text16, text17, text18, text19, text20]

# Medical :
counter_Medicin_Medical = []
counter_Medicin_Medical_file = 0
counter_doctor_Medical = []
counter_doctor_Medical_file = 0
counter_words_Medical = []
TF_doctor_Medical = []
IDF_doctor_Medical = []
TF_IDF_doctor_Medical = []
Total_doctor_Medical = []
TF_Medicin_Medical = []
IDF_Medicin_Medical = []
TF_IDF_Medicin_Medical = []
Total_Medicin_Medical = []

for i, item in enumerate(Medical_text):
    counter_doctor_Medical.append(item.count('پزشک'))
    counter_Medicin_Medical.append(item.count('دارو'))
    counter_words_Medical.append(len(item.split()))

    if counter_doctor_Medical[i] > 0:
        counter_doctor_Medical_file += 1
        TF_doctor_Medical = [
            float(x)/y for x, y in zip(counter_doctor_Medical, counter_words_Medical)]
        IDF_doctor_Medical = math.log(10/counter_doctor_Medical_file)
        TF_IDF_doctor_Medical = np.multiply(
            TF_doctor_Medical, IDF_doctor_Medical)
    if counter_Medicin_Medical[i] > 0:
        counter_Medicin_Medical_file += 1
        TF_Medicin_Medical = [
            float(x)/y for x, y in zip(counter_Medicin_Medical, counter_words_Medical)]
        IDF_Medicin_Medical = math.log(10/counter_Medicin_Medical_file)
        TF_IDF_Medicin_Medical = np.multiply(
            TF_Medicin_Medical, IDF_Medicin_Medical)


print('counter_doctor_Medical :')
print(counter_doctor_Medical, '\n')
print('counter_Medicin_Medical :')
print(counter_Medicin_Medical, '\n')
print('counter_doctor_Medical_file :')
print(counter_doctor_Medical_file, '\n')
print('counter_Medicin_Medical_file :')
print(counter_Medicin_Medical_file, '\n')
print('counter_words_Medical ')
print(counter_words_Medical, '\n')
print('TF_IDF_doctor_Medical :')
print(TF_IDF_doctor_Medical, '\n')
print('TF_IDF_Medicin_Medical :')
print(TF_IDF_Medicin_Medical, '\n')


# Sport :
counter_Medicin_Sport = []
counter_Medicin_Sport_file = 0
counter_doctor_Sport = []
counter_doctor_Sport_file = 0
counter_words_Sport = []
TF_doctor_Sport = []
IDF_doctor_Sport = []
TF_IDF_doctor_Sport = []
TF_Medicin_Sport = []
IDF_Medicin_Sport = []
TF_IDF_Medicin_Sport = []

for i, item in enumerate(Sport_text):
    counter_doctor_Sport.append(item.count('پزشک'))
    counter_Medicin_Sport.append(item.count('دارو'))
    counter_words_Sport.append(len(item.split()))

    if counter_doctor_Sport[i] > 0:
        counter_doctor_Sport_file += 1
        TF_doctor_Sport = [
            float(x)/y for x, y in zip(counter_doctor_Sport, counter_words_Sport)]
        IDF_doctor_Sport = math.log(10/counter_doctor_Sport_file)
        TF_IDF_doctor_Sport = np.multiply(TF_doctor_Sport, IDF_doctor_Sport)
    if counter_Medicin_Sport[i] > 0:
        counter_Medicin_Sport_file += 1
        TF_Medicin_Sport = [
            float(x)/y for x, y in zip(counter_Medicin_Sport, counter_words_Sport)]
        IDF_Medicin_Sport = math.log(10/counter_Medicin_Sport_file)
        TF_IDF_Medicin_Sport = np.multiply(TF_Medicin_Sport, IDF_Medicin_Sport)


print('counter_doctor_Sport :')
print(counter_doctor_Sport, '\n')
print('counter_Medicin_Sport :')
print(counter_Medicin_Sport, '\n')
print('counter_doctor_Sport_file :')
print(counter_doctor_Sport_file, '\n')
print('counter_Medicin_Sport_file :')
print(counter_Medicin_Sport_file, '\n')
print('counter_words_Sport ')
print(counter_words_Sport, '\n')
print('TF_IDF_doctor_Sport :')
print(TF_IDF_doctor_Sport, '\n')
print('TF_IDF_Medicin_Sport :')
print(TF_IDF_Medicin_Sport, '\n')
