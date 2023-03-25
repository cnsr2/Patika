const express = require('express')
const app = express()

app.get('/', function (req, res) {
    res.status(200).send('İNDEX SAYFASI')
})
app.get('/about', function (req, res) {
    res.status(200).send('ABOUT SAYFASI')
})
app.get('/contact', function (req, res) {
    res.status(200).send('CONTACT SAYFASI')
})
app.get('*',(req,res)=>{
 res.status(404).send('SAYFA BULUNAMADI')
})
const port = 3000;
app.listen(port,() =>{
    console.log(`sunucu başarılı bir şekilde ${port} portunda çalışmaya başladı`)
})
