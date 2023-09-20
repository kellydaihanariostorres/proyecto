import Swal from "sweetalert2";
import storage from './Storage/storage';
import axios from 'axios'; 

export function show_alerta(mensaje,icono,foco=''){
  onfocus(foco);
  const MySwal = withReactContent(Swal);
  MySwal.fire({
      title:mensaje,
      icon:icono
  });
}
function onfocus(foco){
  if(foco !== ''){
      document.getElementById(foco).focus();
  }
}


