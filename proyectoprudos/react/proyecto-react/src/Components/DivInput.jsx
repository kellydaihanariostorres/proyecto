import React, {forwardRef,useEffect,useRef}from "react";

export default forwardRef(({type='text',icon='user',placeholder='',
name,id,value,className,required,isFocused,hadleChange},ref)=>{
    const input =ref ? ref :useRef();
    useEffect(()=>{
        if(isFocused){
            input.current.focus();
        }
    },[]);
    return(
        <div className='input-group mb-3'>
            <span className="input-group-text">
                <i className={'fa-solid'+icon}></i>
            </span>
            <input type={type}placeholder={placeholder} mame={name}
            id={id} value={value} className={className} ref={input}
            required={required} onchange={(e)=> hadleChange(e)}/>
        </div>
    )
})