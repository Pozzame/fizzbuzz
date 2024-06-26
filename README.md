# fizzbuzz
## Scrive un numero e scrive a fianco
 - 'fizz' se è divisibile per 3
 - 'buzz' se è divisibile per 5
 - 'fizzbuzz' se è divisibile per entrambi.

 ```c#
 for (int i = 1; i <= 100; i++)
 ```
 Cicla sui primi 100 numeri.

<details>
<summary>info</summary>

Parte da 1 perché altrimenti direbbe 'fizzbuzz' anche a zero;

Uso <= altrimenti si ferma a 99;
</details>

```c#
Console.Write(i + "\t");
```
Stampa il numero e inserisce una tabulazione senza andare a capo.

```c#
if (i % 3 == 0) Console.Write("fizz");
```
Stampa 'fizz' se il numero è divisibile per 3 senza andare a capo.

Altrimenti non scrive niente.

```c#
if (i % 5 == 0) Console.Write("buzz");
```
Stampa 'buzz' se il numero è divisibile per 5 senza andare a capo.

Altrimenti non scrive niente.

# Se quindi è divisibile sia per 3 che per 5 li scrive entrambi.

```c#
Console.Write("\n");
```
In fine va a capo e reincomincia col numero successivo.