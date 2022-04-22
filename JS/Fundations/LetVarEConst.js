/*
let forma = "retangulo";
let altura = 5;
let comprimento = 7;
let area;

if (forma === "retangulo"){
    area = altura * comprimento;
}else{
    area = (altura * comprimento) / 2;
}

console.log(area);
*/


const forma = "triangulo";
const altura = 5;
const comprimento = 7; //const valor fixo, não muda e não pode ser iniciado sem valor
let area; //a let permite que troque os valores dela

if (forma === "quadrado"){
    area = altura * comprimento;
}else{
    area = (altura * comprimento) / 2;
}

console.log(area);