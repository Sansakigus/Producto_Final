from cvzone.HandTrackingModule import HandDetector
import cv2
import socket
#webcam
cap = cv2.VideoCapture(0)
cap.set(3, 1280)
cap.set(4, 720)
#Parametros
success, img = cap.read()
h, w, _ = img.shape
#Detector de la mano
detector = HandDetector(detectionCon=0.8, maxHands=2)
#Servidor
sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
serverAddressPort = ("127.0.0.1", 5052) #Direccion IP y puerto
while True:
    # Obtener la imagen de la webCam
    success, img = cap.read()
    # Manos
    hands, img = detector.findHands(img)  # dibujara un cuadro alrededor de la mano
    data = []
    if hands:
        # Se detecta la primera mano
        hand = hands[0]
        #Lista de puntos de referencia
        lmList = hand["lmList"]  # Lista de la ubicación de los puntas de nuestra mano
        for lm in lmList:
            data.extend([lm[0], h - lm[1], lm[2]])
        sock.sendto(str.encode(str(data)), serverAddressPort) #Enviamos los datos al servidor
    # Mostramos la Imagen
    img = cv2.resize(img, (0,0),None, 0.5,0.5)
    cv2.imshow("Image", img)
    cv2.waitKey(1) #Tiempo de un milisegundo

#Mixamo animaciones (Usar o crear animaciones)