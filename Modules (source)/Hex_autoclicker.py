from pynput.mouse import Controller, Button
from time import sleep

mouse = Controller()

while 1:
    print(mouse.position)


