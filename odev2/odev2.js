const postlar = [{ name: "Post1" },
{ name: "Post2" },
{ name: "Post3" }]

function postEkle(yeniPost) {
    postlar.push(yeniPost)
    const yeniList = postlar.map(function (x) {
        return x.name;
    });
    console.log(yeniList);
}
postEkle({ name: "Post4" });
