#include <Servo.h>
#include <NewPing.h>

/*Aqui se configuran los pines donde debemos conectar el sensor*/
#define TRIGGER_PIN  12
#define ECHO_PIN     11
#define MAX_DISTANCE 30

Servo motorA;  // motor derecho
Servo motorB;  // motor izquierdo
Servo brazo;  // motor derecho

NewPing sonar(TRIGGER_PIN, ECHO_PIN, MAX_DISTANCE);

char x;
double distancia = 0;
/*

  a-> enfrente
  b->atras
  c-> parar

  d->luces a
  e->luces b

*/
void setup() {
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  pinMode(9, OUTPUT);
   digitalWrite(9, 0);
  pinMode(8, OUTPUT);
   digitalWrite(9, 0);
  motorA.attach(2);
  motorB.attach(3);
  brazo.attach(4);
  x = '0';
}



void loop() {
  if (Serial.available() > 0) {
    x = Serial.read();
    // Serial.println(x);
  } else {
    x = '0';
     distancia = getDistancia();
  }

  switch (x) {
    case '0':

      break;
    case 'a'://Avanza banda enfrente
      moverMotor(180, 0);
      break;
    case 'b'://Avanza banda atras
      moverMotor(0, 180);//
      break;
    case 'c'://para la  banda
      moverMotor(90, 90);//Para la banda

      break;
    case 'd'://predne luz
      digitalWrite(8, 1);

      break;
    case 'e'://predne luz
      digitalWrite(9, 1);

      break;
    case 'f'://apaga luz
      digitalWrite(8, 0);

      break;
    case 'g'://apaga luz
      digitalWrite(9, 0);

      break;
    case 'h':

     
    
      if (distancia < 15 && distancia > 5 ) {

        Serial.print("00");

        //moverMotor(180, 0);

      }  if(distancia>15  && distancia<50){

        Serial.print("11");

      }
      break;

    case 'j':
      //es maduro
      break;
    case 'k':
    //es verde
    case 'x':
      digitalWrite(13, HIGH);
      break;
    case 'y':
      digitalWrite(13, LOW);
      break;
    default:
      break;


  }


}


void moverMotor(int a, int b) {
  motorA.write(a);
  motorB.write(b);
}

double getDistancia() {
  delay(1000);
  // Obtener medicion de tiempo de viaje del sonido y guardar en variable uS
  int uS = sonar.ping_median();

  // Calcular la distancia con base en una constante
  return uS / US_ROUNDTRIP_CM;


}

