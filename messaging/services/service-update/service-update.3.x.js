// Download the Node helper library from twilio.com/docs/libraries/node
// These consts are your accountSid and authToken from https://www.twilio.com/console
const accountSid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX';
const authToken = 'your_auth_token';

const client = require('twilio')(accountSid, authToken);

client.messaging
  .services('MG2172dd2db502e20dd981ef0d67850e1a')
  .update({ inboundRequestUrl: 'http://www.example.com' })
  .then(response => {
    console.log(response);
  })
  .catch(error => {
    console.log(error);
  });
