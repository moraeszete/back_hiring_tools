const fetch = require('node-fetch')
const process = require('node:process');
const getServerConfigs = require('../functions/getServiceConfigs')

// async function getTimestamps () {
//   const timestamps = require('../functions/createTimestamps')
//   global.timestamps = timestamps
// }

module.exports = async (opt) => {
  process.on('uncaughtException', function (error, origin) {
    const body = {
      error: {
        name: error.name,
        message: error.message,
      },
      origin,
      projectServerId,
      env: global.configs.env
    }

    const optFetch = {
      method: 'POST',
      body: JSON.stringify(body),
      headers: {
        'Content-Type': 'application/json',
      }
    }
    const url = 'https://api18.b3dev.dev:8001/public/newErrorFromServers'
    fetch(url, optFetch);
    console.log('Caught exception: ' + error);
    console.log(origin, 'origem')
  });

  await getServerConfigs({ projectServerId })
  await getTimestamps()
  await connectMongo()
  await connectSql()
  newRequisitionLog()
  initNotifications()

}