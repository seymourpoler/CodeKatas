function MorseCode(){
  var EMPTY_ARRAY = 0;
  var self = this;
  var codes = [{morse:'.-', text:'a'},
               {morse:'-...', text:'b'},
               {morse:'-.-.', text:'c'},
               {morse:'-..', text:'d'},
               {morse:'.', text:'e'},
               {morse:'..-.', text:'f'},
               {morse:'--.', text:'g'},
               {morse:'....', text:'h'},
               {morse:'..', text:'i'},
               {morse:'.---', text:'j'},
               {morse:'-.-', text:'k'},
               {morse:'.-..', text:'l'},
               {morse:'--', text:'m'},
               {morse:'-.', text:'n'},
               {morse:'---', text:'o'},
               {morse:'---', text:'p'},
               {morse:'--.-', text:'q'},
               {morse:'.-.', text:'r'},
               {morse:'...', text:'s'},
               {morse:'-', text:'t'},
               {morse:'..-', text:'u'},
               {morse:'...-', text:'v'},
               {morse:'.--', text:'w'},
               {morse:'-..-', text:'x'},
               {morse:'-.--', text:'y'},
               {morse:'--..', text:'y'},
               {morse:'..--', text:''},
               {morse:'.-.-', text:''},
               {morse:'---.', text:''},
               {morse:'----', text:''},];

  this.toMorse = function(){
    throw 'not implemented';
  };

  this.toText = function(morseCode){
    var validCodes = codes.filter(function(code){
      return code.morse == morseCode;
    });
    return getTextFrom(validCodes);

    function getTextFrom(translation){
      if(isEmpty(translation)){
        return '';
      }
      return translation[0].text;
    }
  };

  function isEmpty(array){
    return !array || array.length <= EMPTY_ARRAY;
  }
  this.getChatacters = function(morseCode){
    var result = [];
    var accumText = '';
    morseCode.split('').forEach(function(character) {
      accumText = accumText + character
      if(self.toText(character) != ''){
        result.push(self.toText(character));
      }
      if(accumText != character && self.toText(accumText) != ''){
        result.push(self.toText(accumText));
      }
    });
    return result;
  };

  this.getWords = function(morseCode){
    var result = [];
    morseCode.match(/.{1,4}/g).forEach(function(word){
      if(!isEmpty(self.getChatacters(word))){
        result.push(self.getChatacters(word).join(""));
      }
    });
    return result;
  };
}
