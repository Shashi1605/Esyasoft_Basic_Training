#include <avr/io.h>
#include <util/delay.h>

#define led_pin1 PB0
#define button PD2
// #define led_pin2 PD7

int main(void){
    
    DDRB |= (1<<led_pin1);
    DDRD &= ~(1<<button);
    PORTD |= (1<<button);


    while(1){
        //When button is pressed led will blink
        if(!(PIND & (1<<button))){
            PORTB |= (1<<led_pin1);
            _delay_ms(250);
            PORTB &= ~(1<<led_pin1);
            _delay_ms(250);
        }
        
        // _delay_ms(500);
        
        else{
        PORTB &= ~(1<<led_pin1);
        }
        
    

        
    }

}