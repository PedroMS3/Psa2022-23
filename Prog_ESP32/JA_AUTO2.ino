#include <WiFi.h>
#include <ESPAsyncWebSrv.h>

const char* ssid = "Plim_plim";
const char* password = "fsmf8110";
const char* host = "192.168.147.20";
const int httpPort = 80;
WiFiClient client;  


// Constants for endstop pins and reference point detection
const int endstopPin1 = 23;  // Connect endstop 1 to GPIO pin 23
const int endstopPin2 = 18;  // Connect endstop 2 to GPIO pin 18
const int referencePin = 19; // Connect reference point to GPIO pin 19
const int DIREITA = 12;
const int ESQUERDA = 14;

//-------GERAÇÃO DAS STRINGS PARA ENVIAR POR HTTP------------------------
String HTTPReq0;
String HTTPReq1;
String HTTPReq2;
String s0;    //associada ao manual   
String s1;    //associada ao referência
String s2;    //associada ao parar
String s3;   //associada ao direita
String s4;   //associada ao esquerda


bool autoHoming = true;    // Flag to track if auto home process is in progress
bool manual;
bool referenceReached;
bool endstopReached1; 
bool endstopReached2;
bool direita;
bool esquerda;
bool parar;

  
void setup() {
  Serial.begin(115200);
  pinMode(2, OUTPUT);  // Connect output to GPIO pin 2
  pinMode(4, OUTPUT);  // Connect output to GPIO pin 4
  pinMode(DIREITA, INPUT);
  pinMode(ESQUERDA, OUTPUT);
  pinMode(endstopPin1, INPUT);
  pinMode(endstopPin2, INPUT);
  pinMode(referencePin, INPUT);

  
  // Connect to Wi-Fi
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("Connecting to WiFi...");
  }

  Serial.println("Connected to WiFi");
  Serial.println(WiFi.localIP());

  
  manual = 0;
  parar = 0;
  direita = 0;
  esquerda = 0;

  digitalWrite(2, HIGH); 
}


void loop() {


 // Check endstop and reference point conditions
    endstopReached1 = digitalRead(endstopPin1);
    endstopReached2 = digitalRead(endstopPin2);
    referenceReached = digitalRead(referencePin);
    direita = digitalRead(DIREITA);
    esquerda = digitalRead(ESQUERDA);

// Neste caso, o ESP tenta estabelecer ligacao TCP/IP com o Apache (pois o client.status=0)
//if(!client.available()){
//   if (!client.connect(host, httpPort)) { //Tenta LIGAÇAO TCP
//      Serial.println("connection failed");
//      client.flush();
//      delay(1000);
//   } 
//   } 

  
if(autoHoming == true) {
    
  if (referenceReached == 1 && endstopReached1 == 0 && endstopReached2 == 0) {
    digitalWrite(2, LOW);
    digitalWrite(4, LOW);
    Serial.println("Referência alcançada!");
    autoHoming = false;
    manual = true;
  }

  if (endstopReached1 == 1 && autoHoming == 1 && endstopReached2 == 0) {
    digitalWrite(2, LOW);
    digitalWrite(4, HIGH);
    Serial.println("Fim de curso atingido");
    Serial.println("Motor a rodar para a esquerda");
  }

  if (endstopReached2 == 1 && autoHoming == 1 && endstopReached1 == 0) {
    digitalWrite(4, LOW);
    digitalWrite(2, HIGH);
    Serial.println("Fim de curso atingido");
    Serial.println("Motor a rodar para a direita");
  }

  Serial.println("Estado das variáveis");
  Serial.print("Auto Homing: ");
  Serial.println(autoHoming);
  Serial.print("Reference reached: ");
  Serial.println(referenceReached);
  Serial.print("endStopReached2: ");
  Serial.println(endstopReached2);
  Serial.print("endStopReached1: ");
  Serial.println(endstopReached1);
  Serial.println("\n\n");
}



if (manual == true && autoHoming == false) {

  if (direita == 1 && esquerda == 0){
    digitalWrite(4, HIGH);
    digitalWrite(2, LOW);
    Serial.println("Modo manual ativado, motor a rodar para a direita");
  }

  
  else if (direita == 0 && esquerda == 1){
    digitalWrite(2, HIGH);
    digitalWrite(4, LOW);
    Serial.println("Modo manual ativado, motor a rodar para a esquerda");
  }

  
  else{
    digitalWrite(4, LOW);
    digitalWrite(2, LOW);
    Serial.println("Modo manual ativado, motor parado");
  }
  
}

// ----------------- SE LIGACAO TCP ESTABELECIDA ...
// Se o status da ligação for 4, significa que a ligação TCP/IP está estabelecida entre o ESP e o Apache

//if(client.available()){
//
// s0=String(manual);
// s1=String(autoHoming);
// s2=String(parar);
// s3=String(direita);
// s4=String(esquerda);
// 
// String HTTPReq0 = "GET /ControloPortico3.PHP?";
// String HTTPReq1 = "manual="+s0+"&autoHoming="+s1+"&parar="+s2+"&direita="+s3+"&esquerda="+s4;
// String HTTPReq2 = " HTTP/1.1\r\nContent-Type: application/x-www-form-urlencoded\r\nHost: 192.168.25.104\r\nConnection: Close\r\n\r\n";
//
// client.print(HTTPReq0);
// client.print(HTTPReq1);
// client.print(HTTPReq2);
//
// Serial.print("Enviou mensagem para o ESP a pedir o ficheiro PSAPórtico.php");
// Serial.print(HTTPReq0);
// Serial.print(HTTPReq1);
// Serial.print(HTTPReq2);
// delay(10);
//
//}
//
//// ------------------- SE CHEGARAM DADOS por TCP/IP ....
//if (client.available() > 0) { // Se o ESP tiver recebido bytes
//
//  Serial.println("NOVA MENSAGEM CHEGOU!!");
// // Le todos os carateres enviados pelo Apache até receber o caracter 'ç' ou exceder um tempo máximo.
// String line = client.readStringUntil('ç'); //assim, no ESP, já sabe que recebeu a resposta (metemos um ç no final do código em php)
// //Serial.print(line); // envia para o Serial Monitor (para Debug)
//
// if(line.indexOf("manual=1")>0){
//  manual=1;}
// if(line.indexOf("manual=0")>0){
//  manual=0;}
// if(line.indexOf("autoHoming=1")>0){
//  autoHoming=1;}
// if(line.indexOf("autoHoming=0")>0){
//  autoHoming=0;}
// if(line.indexOf("parar=1")>0){
//  parar=1;}
// if(line.indexOf("parar=0")>0){
//  parar=0;}
// if(line.indexOf("direita=1")>0){
//  direita=1;}
// if(line.indexOf("direita=0")>0){
//  direita=0;}
// if(line.indexOf("esquerda=1")>0){
//  esquerda=1;}
// if(line.indexOf("esquerda=0")>0){
//  esquerda=0;}
//
//Serial.println("ESTADO DAS VARIÁVEIS DE CONTROLO");
//Serial.println("Modo Manual: " + String(manual));
////Serial.println("Modo Automático: " + String(autom));
//Serial.println("Modo Referência: " + String(autoHoming));
////Serial.println("Rodar no sentido horário (manual): " + String(ManualSentidoHorario));
////Serial.println("Rodar no sentido antihorário (manual): " + String(ManualSentidoAntiHorario));
////Serial.println("Posição de destino: " + String(destposition));
////Serial.println("Posição atual: " + String(currentPosition));
////Serial.println("Fim curso 1: " + s6);
////Serial.println("Fim curso 2: " + s7);
////Serial.println("Indutivo: " + s9);
////Serial.println();
////Serial.println(); 
////  
// client.flush();
// }  //client available 

  delay(100);
}


// Constants for endstop pins and reference point detection
//const int endstopPin1 = 23;  // Connect endstop 1 to GPIO pin 23
//const int endstopPin2 = 18;  // Connect endstop 2 to GPIO pin 18
//const int referencePin = 19; // Connect reference point to GPIO pin 19
