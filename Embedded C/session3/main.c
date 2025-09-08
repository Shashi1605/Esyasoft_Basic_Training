#include <avr/io.h>
#include <util/delay.h>

#define led1  PD2
#define led2  PD5
#define led3  PD7


int main(void){
    DDRD |= (1<<led1);
    DDRD |= (1<<led2);
    DDRD |= (1<<led3);

    //turing on led1 and led2
    PORTD |= (1<<led1);
    PORTD |= (1<<led2);
    _delay_ms(500);

    while(1){

        //Turning led2 off
        PORTD &= ~(1<<led2);

        //toggling led3
        PORTD ^= (1<<led3);
        _delay_ms(500);
    }
}