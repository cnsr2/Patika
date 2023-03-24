const http = require('http');
const server = http.createServer((req, res) => {
    const url = req.url;

    if(url === '/'){
        res.writeHead(200,{'Content-Type':'text/html'});
        res.write("<h2>Patik'e hoş geldiniz</h2>");
    }
    else if (url === '/hakkimizda'){
        res.writeHead(200,{'Content-Type':'text/html'});
        res.write("<h2>Patik Hakkimizda Sayfasi</h2>");
    }
    else if (url === '/iletisim'){
        res.writeHead(200,{'Content-Type':'text/html'});
        res.write("<h2>Patik İletişim Sayfası</h2>");
    }
    else{
        res.writeHead(200,{'Content-Type':'text/html'});
        res.write("<h2>Patik Sayfa Bulunamadı</h2>");
    }

    res.end();
});
const port = 5000;

server.listen(port, () => {
    console.log(`sunucu bu portta başladı : ${port}`);
});