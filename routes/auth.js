module.exports = () => { 
  global.router.post('/auth/makelogin', require('../controllers/auth/makelogin'))
}