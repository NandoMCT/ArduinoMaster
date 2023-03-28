const int pin00 = 0;
const int pin01 = 1;
const int pin02 = 2;
const int pin03 = 3;
const int pin04 = 4;
const int pin05 = 5;
const int pin06 = 6;
const int pin07 = 7;
const int pin08 = 8;
const int pin09 = 9;
const int pin10 = 10;
const int pin11 = 11;
const int pin12 = 12;
const int pin13 = 13;

void setup() {
  pinMode(pin00, OUTPUT);
  pinMode(pin01, OUTPUT);
  pinMode(pin02, OUTPUT);
  pinMode(pin03, OUTPUT);
  pinMode(pin04, OUTPUT);
  pinMode(pin05, OUTPUT);
  pinMode(pin06, OUTPUT);
  pinMode(pin07, OUTPUT);
  pinMode(pin08, OUTPUT);
  pinMode(pin09, OUTPUT);
  pinMode(pin10, OUTPUT);
  pinMode(pin11, OUTPUT);
  pinMode(pin12, OUTPUT);
  pinMode(pin13, OUTPUT);

  Serial.begin(9600);
}

void loop() {    
  if(Serial.available() > 0 ){
       String str = Serial.readStringUntil('\n');
       char *buf = str.c_str();

       char *rcommand = strtok(buf, ":");
       char *rpin     = strtok(NULL, ":");

       int command = atoi(rcommand);
       int pin = atoi(rpin);

       if(command == 1){
          switch(pin){
          case 0:
          digitalWrite(pin00 , HIGH);
          break;
          case 1:
          digitalWrite(pin01 , HIGH);
          break;
          case 2:
          digitalWrite(pin02 , HIGH);
          break;
          case 3:
          digitalWrite(pin03 , HIGH);
          break;
          case 4:
          digitalWrite(pin04 , HIGH);
          break;
          case 5:
          digitalWrite(pin05 , HIGH);
          break;
          case 6:
          digitalWrite(pin06 , HIGH);
          break;
          case 7:
          digitalWrite(pin07 , HIGH);
          break;
          case 8:
          digitalWrite(pin08 , HIGH);
          break;
          case 9:
          digitalWrite(pin09 , HIGH);
          break;
          case 10:
          digitalWrite(pin10 , HIGH);
          break;
          case 11:
          digitalWrite(pin11 , HIGH);
          break;
          case 12:
          digitalWrite(pin12 , HIGH);
          break;
          case 13:
          digitalWrite(pin13 , HIGH);
          break;
        }
        
       }
       else if(command == 0){
          switch(pin){
          case 0:
          digitalWrite(pin00 , LOW);
          break;
          case 1:
          digitalWrite(pin01 , LOW);
          break;
          case 2:
          digitalWrite(pin02 , LOW);
          break;
          case 3:
          digitalWrite(pin03 , LOW);
          break;
          case 4:
          digitalWrite(pin04 , LOW);
          break;
          case 5:
          digitalWrite(pin05 , LOW);
          break;
          case 6:
          digitalWrite(pin06 , LOW);
          break;
          case 7:
          digitalWrite(pin07 , LOW);
          break;
          case 8:
          digitalWrite(pin08 , LOW);
          break;
          case 9:
          digitalWrite(pin09 , LOW);
          break;
          case 10:
          digitalWrite(pin10 , LOW);
          break;
          case 11:
          digitalWrite(pin11 , LOW);
          break;
          case 12:
          digitalWrite(pin12 , LOW);
          break;
          case 13:
          digitalWrite(pin13 , LOW);
          break;
        }
       }
      }    
 }
