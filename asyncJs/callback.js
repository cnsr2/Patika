// const func1 = () => { 
//     console.log('func1');
// }

// const func2 = () => { 
//     console.log('func2');
// }

// func2();
// func1();
const kitaplar = [{ name: "kitap 1" },
{ name: "kitap 2" },
{ name: "kitap 3" }];

const listele = () =>   { 
    kitaplar.map(function(item) {
        console.log(item.name);
    })
};

const kitapEkle= (yeniKitap) => {
    kitaplar.push(yeniKitap);
    listele();
}

kitapEkle({ name: "kitap 4" });
