const Router =  require('koa-router');
global.router = new Router();

require('./auth')()
// require('./auth/signup')

module.exports = global.router