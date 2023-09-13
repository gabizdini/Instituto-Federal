#include <stdio.h>
#include "biblioteca.h"
#include <windows.h>

int main() {
	int m[100][100], n, c, i, j, escalar;
   
    printf("Digite o numero de linhas: ");
    scanf("%d", &n);

    printf("Digite o numero de colunas: ");
    scanf("%d", &c);
    
    printf("Digite o valor do escalar: ");
    scanf("%d", &escalar);
   
   geraMatriz(m, 100, 100);
   printf("Matriz:\n");
   printMatriz(m, n, c);
   
   printf("Multiplicada por escalar:\n ");
    
   for(i=0; i<n; i++){
   	for(j=0; j<c; j++){
   		
   		printf("%d |", m[i][j] * escalar);
   		
	   }
	   printf("\n");
	}
   
    return 0;
    }

