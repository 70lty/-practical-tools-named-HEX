
import pyautogui, time
from pynput.mouse import Controller, Button
time.sleep(2)

mouse = Controller()

print(mouse.position)

x = mouse.position



for i in range(30):
    pyautogui.leftClick()
    
