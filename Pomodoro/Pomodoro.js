function Pomodoro(duration){
    let self = this;
    const defaultPomodoroTimeInMinutes = 25;

    let time =  duration || defaultPomodoroTimeInMinutes;        
    let isStopped = true;
    let interruptions = 0;
    let timerId;

    self.time = function(){
        return time;
    }

    self.interruptions = function(){
        return interruptions;
    };

    self.isStopped = function(){
        return isStopped;
    };

    self.start = function(){
        isStopped = false;
        const oneSecondInMilliseconds = 1000 ;
        timerId = setInterval(function(){
            time = time -1;
            if(time == 0){
                clearInterval(timerId);
                isStopped = true;
            }
        }, oneSecondInMilliseconds);
    };

    self.stop = function(){
        if(!isStopped){
            clearInterval(timerId);
            isStopped = true;
            interruptions = interruptions + 1;
        }
    };

    self.reset = function(){
        time = duration || defaultPomodoroTimeInMinutes;
        interruptions = 0;
        isStopped = false;
    };
}

module.exports = Pomodoro;

