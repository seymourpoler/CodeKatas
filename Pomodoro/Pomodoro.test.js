let Pomodoro = require('./Pomodoro');

describe('Pomodoro', function(){
    describe('when is created', function(){
        it('has default time', function(){
            const defaultPomodoroTimeInMinutes = 25;
            let pomodoro = new Pomodoro();

            expect(pomodoro.time()).toEqual(defaultPomodoroTimeInMinutes);
        });

        it('sets up time duration', function(){
            const pomodoroDurationInMinutes = 25;
            let pomodoro = new Pomodoro(pomodoroDurationInMinutes);

            expect(pomodoro.time()).toEqual(pomodoroDurationInMinutes);
        });

        it('is stopped', function(){
            let pomodoro = new Pomodoro();

            expect(pomodoro.isStopped()).toBeTruthy();
        });

        it('has no interruptions', function(){
            let pomodoro = new Pomodoro();

            expect(pomodoro.interruptions()).toEqual(0);
        });

        describe('when starts', function(){
            it('begins the count down', async function(){
                const time = 54;
                const twoSeconds = 2000;
                let pomodoro = new Pomodoro(time);

                pomodoro.start();
                await sleep(twoSeconds);
                const currentTime = pomodoro.time();
                
                expect(currentTime).toBeLessThan(time);
                expect(pomodoro.isStopped()).toBeFalsy();
            });

            it('finishes the count down', async function(){
                const time = 2;
                const threeSeconds = 3000;
                let pomodoro = new Pomodoro(time);

                pomodoro.start();
                await sleep(threeSeconds);
                const currentTime = pomodoro.time();
                
                expect(currentTime).toEqual(0);
                expect(pomodoro.isStopped()).toBeTruthy();
            });

            it('can not finish if is not started', async function(){
                const time = 2;
                const threeSeconds = 3000;
                let pomodoro = new Pomodoro(time);

                pomodoro.stop();
                await sleep(threeSeconds);
                const currentTime = pomodoro.time();
                
                expect(currentTime).toEqual(time);
            });

            describe('when stops is requested', function(){
                it('stops the count down', async function(){
                    const time = 2000; 
                    const oneSecond = 1000;
                    const threeSeconds = 3000;
                    let pomodoro = new Pomodoro(time);
                    pomodoro.start();
                    await sleep(oneSecond);

                    pomodoro.stop();
                    await sleep(threeSeconds);

                    expect(pomodoro.time()).toBeLessThan(time);
                });

                const noInterruptions = 0;
                it('returns no interruptions if has not been started', function(){
                    let pomodoro = new Pomodoro();
                    pomodoro.stop();

                    expect(pomodoro.interruptions()).toEqual(noInterruptions);
                });

                it('increment the munber of interruptions', function(){
                    let pomodoro = new Pomodoro();
                    pomodoro.start();

                    pomodoro.stop();

                    expect(pomodoro.interruptions()).toBeGreaterThan(noInterruptions);
                });
            });
        });

        describe('when reseting is requested', function(){
            it('reset interruptions', function(){
                const noInterruptions = 0;
                let pomodoro = new Pomodoro();
                pomodoro.start();

                pomodoro.reset();

                expect(pomodoro.interruptions()).toEqual(noInterruptions);
            });
        });
    });
});

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
  }