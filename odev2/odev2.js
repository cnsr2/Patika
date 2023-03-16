let postlar = [{ name: "Post1" },
{ name: "Post2" },
{ name: "Post3" }]

function postEkle(...yeniPost) {
    postlar = [...postlar, ...yeniPost]
    const yeniList = postlar.map((x) => {
        return x.name;
    });
    console.log(yeniList);
}
postEkle({ name: "Post4" },{ name: "Post5" });
