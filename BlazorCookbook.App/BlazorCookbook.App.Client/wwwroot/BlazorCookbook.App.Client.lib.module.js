
/*designed to intercept brower's copy event and overwrite clipboard data'*/
export function afterWebStarted(blazor)
{
    blazor.registerCustomEventType('preventcopy', {
        browserEventName: 'copy',
        createEventArgs: event => {
            event.clipboardData.setData('text/plain', '---');
            event.preventDefault();
            return {
                stamp: new Date()
            };
        }
    }); 
}

