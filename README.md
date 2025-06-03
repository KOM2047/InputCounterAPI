# InputCounterAPI 📊  

## Description  
A simple .NET API that counts characters in a given input and returns the result.

## Features  
✅ Character counting functionality  
✅ Supports GET and POST requests  
✅ JSON-based API responses  
✅ Built with ASP.NET Core  

## Installation & Setup  
### **Prerequisites**  
- .NET 8 installed  
- Git installed  

### **Setup Instructions**  
1️⃣ Clone the repository:  
   ```bash
   git clone https://github.com/KOM2047/InputCounterAPI.git
2️⃣ Navigate into the project folder:

bash
cd InputCounterAPI
3️⃣ Restore dependencies:

bash
dotnet restore
4️⃣ Build and run the API:

bash
dotnet run
API Endpoints
Method	Endpoint	Description
GET	/count?text=hello	Returns character count for "hello"
POST	/count	Accepts JSON input for counting
Example JSON Request (POST Method)
json
{
  "text": "Hello, World!"
}
Example JSON Response
json
{
  "character_count": 13
}
Deployment
Render Deployment
The API is deployed on Render. 🔗 Live API: https://inputcounterapi.onrender.com/

GitHub Actions for CI/CD
✅ Automatic deployment configured via GitHub Actions ✅ Every push to main triggers deployment on Render

License
📜 MIT License - Free to use and modify.

Author
👨‍💻 Created by Kabelo
