from copy import deepcopy
from random import shuffle

alphabet = []
for nombre in range(97,123):
    alphabet.append(chr(nombre))



clef = deepcopy(alphabet)
shuffle(clef)

message = input("Message (DONT USE MAJ OR SPACE): ")

chiffrage = str()

for lettre in message:
    chiffrage += clef[ord(lettre)-97]


print(clef)
print(chiffrage)