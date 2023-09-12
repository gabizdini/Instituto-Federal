#include <stdio.h>
#include "biblioteca.h"

int main() {
	int num, igual=0, m[100][100], n, c;
   
    printf("Digite o numero de linhas: ");
    scanf("%d", &n);

    printf("Digite o numero de colunas: ");
    scanf("%d", &c);
    

   printf("Digite um numero: ");
   scanf("%d", &num);
   
   geraMatriz(m, 100, 100);
   
   for(int i=0; i<n; i++){
   	for(int j=0; j<c; j++){
   		if(m[i][j] == num){
   			igual++;
		   }
	   }
   }
    printf("O numero %d apareceu %d vezes na matriz.\n", num, igual);

    return 0;
}