#include <avr/io.h>
#include <util/delay.h>

//Defing LED Pin and Button pin
#define led_pin1 PB0
#define button PD2


int main(void){
    
    //Setting PB0 as output for LED
    DDRB |= (1<<led_pin1);

    //Setting PD2 as input for button
    DDRD &= ~(1<<button);
    PORTD |= (1<<button);


    while(1){
        //When button is pressed led will glow and when button is hold led will blink
        if(!(PIND & (1<<button))){
            PORTB |= (1<<led_pin1);
            _delay_ms(250);
            PORTB &= ~(1<<led_pin1);
            _delay_ms(250);
        }
        
        // Led off
        else{
        PORTB &= ~(1<<led_pin1);
        }
  
    }

}