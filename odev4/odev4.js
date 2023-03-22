const fs = require('fs');
// -- burada yeni bir employees.json dosyası oluşturup içini dolduruyoruz 

fs.appendFile("./employees.json", '{"name": "Employee 1 Name", "salary": 2000}', (err) => {
    if (err) throw err;
})

// -- burada oluşturduğumuz dosyayı okuyoruz

fs.readFile("./employees.json", 'utf8', (err, data) => {
    if (err) throw err;
    console.log(data);
});

// -- burada dosyamızın içeriğini güncelliyoruz 

fs.writeFile("./employees.json", '{"sale":20}"', 'utf-8', (err) => {
    if (err) throw err;
    console.log("Dosya'ya Güncellendi");
});

//-- burada dosyamızın içeriğini siliyoruz
fs.unlink("./employees.json", (err) => {
    if (err) throw err;
});