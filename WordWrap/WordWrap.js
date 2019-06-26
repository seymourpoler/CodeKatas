function wordWrap(text, numberOfColumns){
    if(text.length < numberOfColumns){
        return text;
    }
    const wrapText = text.substring(0, numberOfColumns);
    const remain = text.substring(numberOfColumns, text.length);
    return wrapText + '\n' + remain;
    
    throw 'not implemented';
}

module.exports = wordWrap;

