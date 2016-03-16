describe("Morse Code Translator", function(){
  var translator;

  beforeEach(function(){
    translator = new MorseCode();
  });

  it("translate morse into character", function(){
    var result = translator.toText('.-');

    expect(result).to.eql('a');
  });

  it("translate morse into character with invalid morse code", function(){
    var result = translator.toText('----');

    expect(result).to.eql('');
  });

  it("returns string empty if morse code does not exist", function(){
    var result = translator.toText('-----.');

    expect(result).to.eql('');
  });

  it("returns all translate words from morse code", function(){
    var result = translator.getChatacters('.-');

    expect(result).to.eql(['e', 't', 'a']);
  });

  it("retuns all possible words from morse code", function(){
    var result = translator.getWords('-..-----.');

    expect(result).to.eql(['njg', 'dog', 'xmg', 'xon']);
  });
});
