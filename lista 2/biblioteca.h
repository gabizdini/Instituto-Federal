#include <stdio.h>
#include <stdlib.h>
#include 'time'
void printMatriz(int m[][100],int linhas,int colunas){
    int i,j;
    for(i=0;i<linhas;i++){
        for(j=0;j<colunas;j++)
           printf("%3d |", m[i][j]);
      printf("\n");      
    }// fim for i
    printf("\n");
} //  fim print

void geraMatriz(int m[][100],int linhas,int colunas){
    int i,j;
    srand(time(NULL));
    for(i=0;i<linhas;i++)
        for(j=0;j<colunas;j++)
           m[i][j]=rand()%50;
} //  fim gera

void leiaMatriz(int m[][100],int linhas,int colunas){
    int i,j;
    srand(time(NULL));
    for(i=0;i<linhas;i++)
        for(j=0;j<colunas;j++)
           scanf("%d",&m[i][j]);
} //  fim gera

void leiaMatrizArquivo(int m[][100],int linhas,int colunas){
    FILE *arq;
    int i,j;
    arq= fopen("temperaturas.txt","r");
    if(arq==NULL)
       printf("Arquivo nao encontrado\n");
    for(i=0;i<linhas;i++){
       for(j=0;j<colunas;j++){
              fscanf(arq,"%d",&m[i][j]);
        }// fim for j
    }// fim for i    
}// fim le

