const Koa = require('koa')
const app = new Koa()
const cors = require('@koa/cors')
const bodyParser = require('koa-bodyparser')
const serve = require('koa-static')
// const mount = require('koa-mount')
const path = require('path')

app.use(cors())
app.use(bodyParser())

const router = require('./routes')  

app.use( async (ctx, next)  => {
  // ctx.set('')
  ctx.set('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, PATCH, DELETE')
  ctx.set('Access-Control-Allow-Origin', '*')
  ctx.set('Access-Control-Allow-Credentials', true)
  await next()
})
// app.use( async (ctx) => {
//   ctx.body = 'Hello, Koa on AWS!';
//   return ctx.body = {
//     message: 'Hello, Koa on AWS!',
//    }
//   await next()
// }) 

app.use( async (ctx, next) => {
  const route = ctx.path.split('/')
  if(route[1] === 'public') {
    console.log('rota chamada: ', route)
  }
  // rotas de excessão login, signup, etc
  const exceptions = [
    '/public/auth/signup',
  ]

  const map = exceptions.includes(ctx.path)

  if(!map && !ctx.headers.authorization) {
    return ctx.body = {
      error: true,
      errorMessage: 'Sessão expirada. Faça login novamente.',
    }

  }
  //
  await next()
})

app.use(router.routes())
app.use(router.allowedMethods())

module.exports = app