numbers = ['',0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18]

fic = open("mail.txt", "w")

nameFile = open('Nom.txt', 'r')
firstNameFile = open("Prenom.txt", 'r')

names = nameFile.read().split()
firstNames = firstNameFile.read().split()

nameFile.close()
firstNameFile.close()

print(names)
