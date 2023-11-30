var listaFilmes = [
"https://upload.wikimedia.org/wikipedia/pt/thumb/1/1b/Schoolrockposter.jpg/210px-Schoolrockposter.jpg", 
"https://static.wixstatic.com/media/da06f2_9e0748f8e4fc45eba701ee2bd5581c11~mv2.jpg/v1/fill/w_640,h_998,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/da06f2_9e0748f8e4fc45eba701ee2bd5581c11~mv2.jpg",
"https://musicart.xboxlive.com/7/94fc5000-0000-0000-0000-000000000002/504/image.jpg"
];

for (var i=0; i< listaFilmes.length; i++) {
    document.write("<img src=" + listaFilmes[i] + ">");
}
