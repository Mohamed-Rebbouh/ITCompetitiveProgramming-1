#include<stdio.h>
#include<stdlib.h>

int test(char *ch,int size){
                int i;
if(ch[0]>=65){
    for(i=1;i<size;i++){
     if(ch[i]<65 || ch[i]>90){
        return 0;


        }
}}

else {if(ch[0]>=97){
    for(i=1;i<size;i++){
    if(ch[i]<97 || ch[i]>122){
               return 0;
    }

    }}


}
return 1;
}

int main(){
char n[3]={'M','O','H'};
printf("%d",test(n,3));
return 0;



}

