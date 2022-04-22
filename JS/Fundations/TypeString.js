//type string

const texto = "Olá Mundo";
const texto2 = 'Hello "Word"';


const citacao = "Meu nome é: ";
const nome = "Janaina"

console.log(texto)
console.log(texto2)

console.log(citacao + nome)

//template string ou Template Literal


//concatenação



const cifrao = '\u0024'
const aMaiusculo = '\u0041'
const tique = '\u2705'
const hiragana = '\u3041'

console.log(cifrao)
console.log(aMaiusculo)
console.log(tique)
console.log(hiragana)


const cidade = "belo horizonte";
const input = "Belo Horizonte";

const inputMinusculo = input.toLowerCase();

console.log(cidade === inputMinusculo); // true

const senha = "minhaSenha123"
console.log(senha.length) // 13 caracteres


////null undefined

let input2 = null;

if (input2 === null) {
 console.log('não há informação');
} else {
 console.log(input2);
}



let input3 = null;
let input4;

console.log(input3); // null
console.log(input4); // undefined