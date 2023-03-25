const Koa = require('koa');
const router = require('koa-router');
const app = new Koa();
const rou = router();
rou.get("index","/", (ctx)=> {
    ctx.body = "<h1>Ana Sayfa</h1> "
})
rou.get("about","/about", (ctx)=> {
    ctx.body = "<h1>Hakkımızda</h1> "
})
rou.get("contact","/contact", (ctx)=> {
    ctx.body = "<h1>Iletişim</h1> "
})



app.use(rou.routes())
app.use(rou.allowedMethods());

const port = 5000

app.listen(port,()=>{
    console.log(`Sunucu ${port} portunda çalışmaya başladı`)
});