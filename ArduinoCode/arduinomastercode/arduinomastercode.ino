const int led = 2;

void setup() {
  pinMode(led, OUTPUT);
  Serial.begin(9600);
}

void loop() {       
  char c = Serial.read();

  if(c == 'l'){
      digitalWrite(led, HIGH);   
  }
  else if(c == 'd'){
    digitalWrite(led, LOW);   
  }
 }
