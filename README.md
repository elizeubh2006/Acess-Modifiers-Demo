# Projeto de Demonstração de Modificadores de Acesso em C#

Este projeto foi criado para ajudar estudantes de programação a compreender os modificadores de acesso em C#. Utilizando uma classe `Parent`, uma classe derivada `DerivedClass` e uma classe qualquer `SomeClass`, demonstramos a tentativa de acesso a membros, como uma conversa entre as classes.

## Como Usar

Você pode testar o projeto usando o [[**.NET Fiddle**](https://dotnetfiddle.net/CpQYyq)](https://dotnetfiddle.net/CpQYyq). O código fonte está disponível para você estudar e fazer seus próprios testes.

## Estrutura do Projeto

•  [**Parent**](https://www.bing.com/search?form=SKPBOT&q=Parent): Classe base com diferentes modificadores de acesso.

•  [**DerivedClass**](https://www.bing.com/search?form=SKPBOT&q=DerivedClass): Classe derivada que tenta acessar os membros da classe `Parent`.

•  [**SomeClass**](https://www.bing.com/search?form=SKPBOT&q=SomeClass): Classe independente que também tenta acessar os membros da classe `Parent`.


## Modificadores de Acesso

•  [**public**](https://www.bing.com/search?form=SKPBOT&q=public): Acessível de qualquer lugar.

•  [**private**](https://www.bing.com/search?form=SKPBOT&q=private): Acessível apenas dentro da própria classe.

•  [**protected**](https://www.bing.com/search?form=SKPBOT&q=protected): Acessível dentro da própria classe e por classes derivadas (independente do assembly).

•  [**internal**](https://www.bing.com/search?form=SKPBOT&q=internal): Acessível dentro do mesmo assembly.

•  [**protected internal**](https://www.bing.com/search?form=SKPBOT&q=protected%20internal): Acessível dentro do mesmo assembly e por classes derivadas em outro assembly.

•  [**private protected**](https://www.bing.com/search?form=SKPBOT&q=private%20protected): Acessível apenas dentro da própria classe ou por classes derivadas no mesmo assembly.

## Imagem do Resultado

![alt text](https://github.com/elizeubh2006/Acess-Modifiers-Demo/blob/master/ResultadoAccessModifiersDemo.PNG?raw=true)

## Sugestões de Melhorias

•  Sugestões serão sempre bem-vindas. 


## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

```markdown
MIT License

Copyright (c) 2024 ELIZEU S FERREIRA

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
