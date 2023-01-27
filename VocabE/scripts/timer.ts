"use strict";
export default async function(callback) {
    const before : number = Date.now();
    await callback().finally(result => result);
    const after : number = Date.now(); 
    return (after - before)/1000;
}