#include <WiFi.h>
#include <ESPAsyncWebSrv.h>

const char* ssid = "A_mae_do_miguel";
const char* password = "fsmf8110";

AsyncWebServer server(80);

// Constants for endstop pins and reference point detection
const int endstopPin1 = 5;  // Connect endstop 1 to GPIO pin 5
const int endstopPin2 = 18;  // Connect endstop 2 to GPIO pin 18
const int referencePin = 19; // Connect reference point to GPIO pin 19

bool autoHoming = false;    // Flag to track if auto home process is in progress

void setup() {
  Serial.begin(9600);
  pinMode(2, OUTPUT);  // Connect output to GPIO pin 2
  pinMode(4, OUTPUT);  // Connect output to GPIO pin 4
  pinMode(endstopPin1, INPUT_PULLUP);
  pinMode(endstopPin2, INPUT_PULLUP);
  pinMode(referencePin, INPUT_PULLUP);

  // Connect to Wi-Fi
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("Connecting to WiFi...");
  }

  Serial.println("Connected to WiFi");
  Serial.println(WiFi.localIP());

  // Route for root path ("/")
  server.on("/", HTTP_GET, [](AsyncWebServerRequest* request) {
    String htmlPage = "<html><body>";
    htmlPage += "<h1>Control Outputs</h1>";
    htmlPage += "<button onclick=\"sendData('on2')\">Turn ON Output 2</button>";
    htmlPage += "<button onclick=\"sendData('off2')\">Disconnect Output 2</button>";
    htmlPage += "<button onclick=\"sendData('on4')\">Turn ON Output 4</button>";
    htmlPage += "<button onclick=\"sendData('off4')\">Disconnect Output 4</button>";
    htmlPage += "<br><br>";
    htmlPage += "<button onclick=\"sendData('autohome')\">Auto Home</button>";
    htmlPage += "<script>function sendData(command) {";
    htmlPage += "var xhttp = new XMLHttpRequest();";
    htmlPage += "xhttp.open('GET', '/' + command, true);";
    htmlPage += "xhttp.send();}</script>";
    htmlPage += "</body></html>";
    request->send(200, "text/html", htmlPage);
  });

  // Route for turning on/off outputs
  server.on("/on2", HTTP_GET, [](AsyncWebServerRequest* request) {
    digitalWrite(2, HIGH);  // Turn on output connected to GPIO pin 2
    request->send(200, "text/plain", "Output 2 turned ON");
  });

  server.on("/off2", HTTP_GET, [](AsyncWebServerRequest* request) {
    digitalWrite(2, LOW);  // Disconnect output connected to GPIO pin 2
    request->send(200, "text/plain", "Output 2 disconnected");
  });

   server.on("/on4", HTTP_GET, [](AsyncWebServerRequest* request) {
    digitalWrite(4, HIGH);  // Turn on output connected to GPIO pin 4
    request->send(200, "text/plain", "Output 4 turned ON");
  });

  server.on("/off4", HTTP_GET, [](AsyncWebServerRequest* request) {
    digitalWrite(4, LOW);  // Disconnect output connected to GPIO pin 4
    request->send(200, "text/plain", "Output 4 disconnected");
  });

  server.on("/autohome", HTTP_GET, [](AsyncWebServerRequest* request) {
    if (!autoHoming) {
      autoHoming = true;
      digitalWrite(2, HIGH); // Start moving towards reference point
    }
    request->send(200, "text/plain", "Auto Home function executed");
  });

  // Start the server
  server.begin();
}

void loop() {
  bool referenceReached = false;
  bool endstopReached1 = false;
  bool endstopReached2 = false;

  if (autoHoming) {
    // Check endstop and reference point conditions
    endstopReached1 = digitalRead(endstopPin1) == HIGH;
    endstopReached2 = digitalRead(endstopPin2) == HIGH;
    referenceReached = digitalRead(referencePin) == HIGH;

  } else if (referenceReached) {
      autoHoming = false;
      digitalWrite(2, LOW); // Stop moving
      digitalWrite(4, LOW); // Stop moving
      
  } else if (endstopReached1) {
      digitalWrite(4, HIGH);
      Serial.println("Endstop 1 reached. Moving away to endstop 2.");

  } else if  (endstopReached2) {
      digitalWrite(2, HIGH);
      Serial.println("Endstop 2 reached. Moving away to endstop 1.");
        
  } else {
      Serial.println("Reference point reached. Auto Home successful.");
  }
    
  delay(100);
}
