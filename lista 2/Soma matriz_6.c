#include <stdio.h>
#include "biblioteca.h"
#include <windows.h>

int main() {
	int m[100][100], m2[100][100], n, c, i, j;
   
    printf("Digite o numero de linhas: ");
    scanf("%d", &n);

    printf("Digite o numero de colunas: ");
    scanf("%d", &c);
   
   geraMatriz(m, 100, 100);
   printf("Matriz 1:\n");
   printMatriz(m, n, c);

   Sleep(3000);
   printf("\n");
   
   geraMatriz(m2, 100, 100);
   printf("Matriz 2:\n");
   printMatriz(m2, n, c);
   
   printf("Somas das matrizes: ");
    
   for(i=0; i<n; i++)
   	for(j=0; j<c; j++){
   		
   		printf("%d ", m[i][j]+m2[i][j]);
   		
	   }
   
    return 0;
    }
