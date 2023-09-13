#include <stdio.h>
#include "biblioteca.h"
#include <windows.h>

int Addconstante(int matriz[][100], int linhas, int coluna, int constante){
	for(int i=0; i<linhas; i++){
		for(int j=0; j<coluna; j++)
			matriz[i][j] += constante;
	}
}
int main() {
	float m[100][100], m2[100][100], constante;
	int opcao, n, c, i , j;
   
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
   
    printf("[1] Soma\n");
    printf("[2] Subtrair\n");
    printf("[3] Adicionar constante\n");
    printf("[4] Gerar novamente\n");
    printf("Escolha uma opcao: ");
    scanf("%d", &opcao);
   
	switch (opcao){
	for(i=0; i<n; i++){
		for(j=0; j<c; j++)
		case 1:
			printf("Soma: %f%f", m[i][j] + m2[i][j]);
			break;
		case 2:
			printf("Subtrair: ",m[i][j] - m2[i][j]);
			break;
		case 3:
			printf("Constante:");
			scanf("%3f", constante);
			Addconstante(m, n, c, constante);
			Addconstante(m2, n, c, constante);
			break;
		case 4:
		printf("Matriz 1: \n", m[i][j]);
		printf("\nMatriz 2: \n", m2[i][j]);
	   break;
	   
	    default:
            printf("Opcao invalida.\n");
			}//fim i
		}//fim switch
    return 0;
}
//sujeito a erros
