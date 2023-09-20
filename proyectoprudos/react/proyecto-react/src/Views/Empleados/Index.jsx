import React, { useEffect, useState } from 'react';
import axios from 'axios';

const Empleados = () => {
  const url = 'https://localhost:7284/api/empleados';
  const [empleados, setEmpleados] = useState([]);
  const [empleadoId, setEmpleadoId] = useState('');
  const [nombre, setNombre] = useState('');
  const [apellido, setApellido] = useState('');
  const [documento, setDocumento] = useState('');
  const [cargo, setCargo] = useState('');
  const [sueldo, setSueldo] = useState('');
  const [fechaInicio, setFechaInicio] = useState('');
  const [fechaFin, setFechaFin] = useState('');
  const [bodegaId, setBodegaId] = useState('');
  const [operation, setOperation] = useState(1);
  const [title, setTitle] = useState('');

  useEffect(() => {
    getEmpleados();
  }, []);

  const getEmpleados = async () => {
    try {
      const respuesta = await axios.get(url);
      setEmpleados(respuesta.data);
    } catch (error) {
      console.error(error);
    }
  };

  const openModal = (op,
     id,
      nombre,
      apellido, 
      documento, 
      cargo, 
      sueldo, 
      fechaInicio, 
      fechaFin,
      bodegaId
      ) => {
    setEmpleadoId(id);
    setOperation(op);
    if (op === 1) {
      setTitle('Registrar Empleado');
      setNombre('');
      setApellido('');
      setDocumento('');
      setCargo('');
      setSueldo('');
      setFechaInicio('');
      setFechaFin('');
      setBodegaId('')
    } else if (op === 2) {
      setTitle('Editar Empleado');
      setNombre(nombre);
      setApellido(apellido);
      setDocumento(documento);
      setCargo(cargo);
      setSueldo(sueldo);
      setFechaInicio(fechaInicio);
      setFechaFin(fechaFin);
      setBodegaId(bodegaId)
    }
    window.setTimeout(function () {
      document.getElementById('nombre').focus();
    }, 500);
  };

  const validar = () => {
    if (nombre.trim() === '') {
      show_alerta('Digita el nombre del empleado', 'warning');
    } else if (apellido.trim() === '') {
      show_alerta('Digita el apellido del empleado', 'warning');
    } else if (documento.trim() === '') {
      show_alerta('Digita numero de documento del empleado', 'warning');
    } else if (cargo.trim() === '') {
      show_alerta('Digita el cargo del empleado', 'warning');
    } else if (sueldo === '') {
      show_alerta('Digita el sueldo del empleado', 'warning');
    } else if (fechaInicio === '') {
      show_alerta('Digita la fecha de ingreso del empleado', 'warning');
    } else if (fechaFin === '') {
      show_alerta('Digita la fecha de retiro del empleado', 'warning');
    } else {
      const parametros = {
        nombre: nombre.trim(),
        apellido: apellido.trim(),
        documento: documento.trim(),
        cargo: cargo.trim(),
        fechaInicio: fechaInicio.trim(),
        fechaFin: fechaFin.trim(),
        sueldo: sueldo,
        bodegaId: bodegaId
      };
      const metodo = operation === 1 ? 'POST' : 'PUT';
      enviarSolicitud(metodo, parametros);
    }
  };

  const enviarSolicitud = async (metodo, parametros) => {
    const idParam = empleadoId || '';
    try {
      const response = await axios[metodo.toLowerCase()](
        idParam ? `${url}/${idParam}` : url,
        parametros
      );
      const tipo = response.data[0];
      const msj = response.data[1];
      show_alerta(msj, tipo);
      if (tipo === 'success') {
        document.getElementById('btnCerrar').click();
        getEmpleados();
      }
    } catch (error) {
      show_alerta('Error de solicitud', 'error');
      console.log(error);
    }
  };

  const deleteEmpleados = (id, nombre) => {
    const MySwal = withReactContent(Swal);
    MySwal.fire({
      title: '¿Seguro que desea eliminar el empleado?',
      icon: 'question',
      text: 'No se podrá dar marcha atrás',
      showCancelButton: true,
      confirmButtonText: 'Sí, eliminar',
      cancelButtonText: 'Cancelar',
    }).then(async (result) => {
      if (result.isConfirmed) {
        try {
          await axios.delete(`${url}/${empleadoId}`);
          show_alerta('Usuario eliminado exitosamente', 'success');
          getEmpleados();
        } catch (error) {
          show_alerta('Error al eliminar el usuario', 'error');
          console.error(error);
        }
      } else {
        show_alerta('El producto no fue eliminado', 'info');
      }
    });
  };

  return (
    <div className='App'>
      <div className='container-fluid'>
        <div className='row mt-3'>
          <div className='col-md-4 offset-md-4'></div>
        </div>
        <div className='row mt-3'>
          <div className='col-md-4 offset-md-4'>
            <div className='d-grid mx-auto'>
              <button
                onClick={() => openModal(1)}
                className='btn btn-dark'
                data-bs-toggle='modal'
                data-bs-target='#modalEmpleados'
              >
                <i className='fa-solid fa-circle-plus'></i> Añadir
              </button>
            </div>
          </div>
        </div>
        <div className='row mt-3'>
          <div className='col-12 col-lg-8 offset-0 offset-lg-12'>
            <div className='table-responsive'>
              <table className='table table-bordered'>
                <thead>
                  <tr>
                    <th>#</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Numero de Documento</th>
                    <th>Cargo</th>
                    <th>Sueldo</th>
                    <th>Fecha de Inicio</th>
                    <th>Fecha Fin</th>
                    <th>Acciones</th>
                  </tr>
                </thead>
                <tbody className='table-group-divider'>
                  {empleados.map((empleado, i) => (
                    <tr key={empleado.id}>
                      <td>{i + 1}</td>
                      <td>{empleado.nombre}</td>
                      <td>{empleado.apellido}</td>
                      <td>{empleado.documento}</td>
                      <td>{empleado.cargo}</td>
                      <td>{empleado.sueldo}</td>
                      <td>{empleado.fechaInicio}</td>
                      <td>{empleado.fechaFin}</td>
                      <td>
                        <button
                          onClick={() =>
                            openModal(
                              2,
                              empleado.empleadoId,
                              empleado.nombre,
                              empleado.apellido,
                              empleado.documento,
                              empleado.cargo,
                              empleado.sueldo,
                              empleado.fechaInicio,
                              empleado.fechaFin
                            )
                          }
                          className='btn btn-warning'
                          data-bs-toggle='modal'
                          data-bs-target='#modalEmpleados'
                        >
                          <i className='fa-solid fa-edit'></i>
                        </button>
                        &nbsp;
                        <button onClick={() => deleteEmpleados(empleado.empleadoId, empleado.nombre)} className='btn btn-danger'>
                          <i className='fa-solid fa-trash'></i>
                        </button>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>
          </div>
        </div>
      </div>
      <div id='modalEmpleados' className='modal fade' aria-hidden='true'>
        <div className='modal-dialog'>
          <div className='modal-content'>
            <div className='modal-header'>
              <label className='h5'>{title}</label>
              <button type='button' className='btn-close' data-bs-dismiss='modal' aria-label='Close'></button>
            </div>
            <div className='modal-body'>
              <input type='hidden' id='id'></input>
              <div className='input-group mb-3'>
                <span className='input-group-text'>
                  <i className='fa-solid fa-gift'></i>
                </span>
                <input
                  type='text'
                  id='nombre'
                  className='form-control'
                  placeholder='Nombre'
                  value={nombre}
                  onChange={(e) => setNombre(e.target.value)}
                ></input>
              </div>
              <div className='input-group mb-3'>
                <span className='input-group-text'>
                  <i className='fa-solid fa-gift'></i>
                </span>
                <input
                  type='text'
                  id='apellido'
                  className='form-control'
                  placeholder='Apellido'
                  value={apellido}
                  onChange={(e) => setApellido(e.target.value)}
                ></input>
              </div>
              <div className='input-group mb-3'>
                <span className='input-group-text'>
                  <i className='fa-solid fa-gift'></i>
                </span>
                <input
                  type='text'
                  id='documento'
                  className='form-control'
                  placeholder='Numero de documento'
                  value={documento}
                  onChange={(e) => setDocumento(e.target.value)}
                ></input>
              </div>
              <div className='input-group mb-3'>
                <span className='input-group-text'>
                  <i className='fa-solid fa-gift'></i>
                </span>
                <input
                  type='text'
                  id='cargo'
                  className='form-control'
                  placeholder='Cargo'
                  value={cargo}
                  onChange={(e) => setCargo(e.target.value)}
                ></input>
              </div>
              <div className='input-group mb-3'>
                <span className='input-group-text'>
                  <i className='fa-solid fa-gift'></i>
                </span>
                <input
                  type='text'
                  id='sueldo'
                  className='form-control'
                  placeholder='Sueldo'
                  value={sueldo}
                  onChange={(e) => setSueldo(e.target.value)}
                ></input>
              </div>
              <div className='input-group mb-3'>
                <span className='input-group-text'>
                  <i className='fa-solid fa-gift'></i>
                </span>
                <input
                  type='text'
                  id='fechaInicio'
                  className='form-control'
                  placeholder='Fecha de inicio'
                  value={fechaInicio}
                  onChange={(e) => setFechaInicio(e.target.value)}
                ></input>
              </div>
              <div className='input-group mb-3'>
                <span className='input-group-text'>
                  <i className='fa-solid fa-gift'></i>
                </span>
                <input
                  type='text'
                  id='fechaFin'
                  className='form-control'
                  placeholder='Fecha de retiro'
                  value={fechaFin}
                  onChange={(e) => setFechaFin(e.target.value)}
                ></input>
              </div>
              <div className='d-grid col-6 mx-auto'>
                <button onClick={() => validar()} className='btn btn-success'>
                  <i className='fa-solid fa-floppy-disk'></i> Guardar
                </button>
              </div>
            </div>
            <div className='modal-footer'>
              <button type='button' EmpleadoId='btnCerrar' className='btn btn-secondary' data-bs-dismiss='modal'>
                Cerrar
              </button>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Empleados