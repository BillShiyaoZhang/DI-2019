#define PIR_MOTION_SENSOR 2

void setup() {
  // put your setup code here, to run once:
  pinMode(PIR_MOTION_SENSOR, INPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(digitalRead(PIR_MOTION_SENSOR))//if it detects the moving people?
    Serial.println("1");  // Hi,people is coming
  else
    Serial.println("0");  // Watching

  delay(200);
}
