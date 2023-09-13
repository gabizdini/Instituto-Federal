#include <stdio.h>
#include "biblioteca.h"

int main() {
	int m[100][100], n, c, j;
   
    printf("Digite o numero de linhas: ");
    scanf("%d", &n);

    printf("Digite o numero de colunas: ");
    scanf("%d", &c);
   
   geraMatriz(m, 100, 100);
   printMatriz(m, n, c);
   
      printf("\nDiagonal Secundaria:\n");

    	for (int i = 0; i < n; i++){
        printf("%d |", m[i][n-i-1]);
    }

    printf("\n");
    return 0;
}
