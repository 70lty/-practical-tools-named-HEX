from random import *
liste=['a','b','c','d','e','f','g','h','i','j','k','m','n','l','o','p','q','r','s','t','u','v','w','x','y','z',' ']
for x in range(len(liste)):    
    liste.append(liste[x])
message = input('Entrez votre message : ')
clef = int(input('Entrez votre clef ( entre 1 et 25 ) : '))  
def chiffrage_lettre(lettre,liste,clef):
    for i in range(len(liste)):
        if lettre==' ':       
            return ' '
        elif liste[i]==lettre:
            return str(liste[i+clef])
    return 'Dont use Maj'  
message_chiffré = str()
for lettre in message:
    message_chiffré += chiffrage_lettre(lettre,liste,clef)
print(message_chiffré)
