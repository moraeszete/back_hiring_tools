const path = require('path')  
const dotenv = require('dotenv')
dotenv.config({ path: path.join(__dirname, '.env')})
// configure dotenv 
let server;

async function createServer(){
  // await configServer()
  const app = require('./customApp')
  const today = new Date()

  server = app.listen(process.env.PORT, () => { 
    console.log('Server running on port', process.env.PORT, today)
  })  
}

createServer()

module.exports = server;