// tipo de dado
// boolean

//conversão implicita

const numero = 123;
const numeroString = "123";

console.log(numero + numeroString);

//conversão explicita

const numero1 = 123;
const numeroString1 = Number("123");

console.log(numero1 + numeroString1);


let telefone = 12341234;
console.log("O telefone é " + telefone.toString()); 
// o .toString() é uma outra forma para  fazer essa conversão, que é mais parecida com outras linguagens de programação.

let usuarioConectado = false;
console.log(String(usuarioConectado)); 
// teremos a conversão da booleana para string, nesse caso teremos uma string “false”.
usuarioConectado = true;
console.log(String(usuarioConectado)); 
// agora teremos uma string “true”.

// Vamos calcular a área de um retângulo
let largura = "10";
let altura = "5";
console.log(Number(largura) * Number(altura)); 
// teremos a conversão de String para números, possibilitando a realização da da multiplicação

let largura1 = "10";
let altura1 = "5";
console.log( + largura1 * + altura1); 
// teremos a conversão de String para números realizado usando o + antes das variáveis

