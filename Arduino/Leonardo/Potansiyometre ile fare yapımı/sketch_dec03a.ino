#include <Mouse.h>

const int xPotPin = A0; // X ekseni için potansiyometre
const int yPotPin = A1; // Y ekseni için potansiyometre
const int leftButtonPin = 2; // Sol tıklama butonu
const int rightButtonPin = 3; // Sağ tıklama butonu
const int middleButtonPin = 4; // Orta tıklama butonu

void setup() {
  // Potansiyometreler için analog pinleri giriş olarak ayarlıyoruz
  pinMode(xPotPin, INPUT);
  pinMode(yPotPin, INPUT);
  
  // Butonlar için dijital pinleri giriş olarak ayarlıyoruz
  pinMode(leftButtonPin, INPUT); 
  pinMode(rightButtonPin, INPUT); 
  pinMode(middleButtonPin, INPUT);
  
  // Fareyi kontrol etmeye başlıyoruz
  Mouse.begin();
}

void loop() {
  // Butonlardan birine basıldığında fareyi hareket ettir
  bool moveMouse = true;

  // Sol tıklama butonunu kontrol et
  if (digitalRead(leftButtonPin) == HIGH) {
    Mouse.press(MOUSE_LEFT);
    moveMouse = true;
  } else {
    Mouse.release(MOUSE_LEFT);
  }

  // Sağ tıklama butonunu kontrol et
  if (digitalRead(rightButtonPin) == HIGH) {
    Mouse.press(MOUSE_RIGHT);
    moveMouse = true;
  } else {
    Mouse.release(MOUSE_RIGHT);
  }

  // Orta tıklama butonunu kontrol et
  if (digitalRead(middleButtonPin) == HIGH) {
    Mouse.press(MOUSE_MIDDLE);
    moveMouse = true;
  } else {
    Mouse.release(MOUSE_MIDDLE);
  }

  // Eğer bir butona basıldıysa fareyi hareket ettir
  if (moveMouse) {
    // Potansiyometre değerlerini alıyoruz (0-1023 arası)
    int xValue = analogRead(xPotPin);  
    int yValue = analogRead(yPotPin);  

    // X ve Y değerlerini fare hareketi için uygun bir aralığa çeviriyoruz
    int mouseX = map(xValue, 0, 1023, -50, 50); 
    int mouseY = map(yValue, 0, 1023, -50, 50);
    
    // Fareyi hareket ettiriyoruz
    Mouse.move(mouseX, mouseY);
  }

  delay(10);  // Küçük bir gecikme, fare hareketlerinin daha düzgün olması için
}
