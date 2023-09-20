import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';
import DivAdd from '../../Components/DivAdd';
import DivTable from '../../Components/DivTable';
import { confirmation, sendRequest } from '../../funcions';

const Bodegas = () => {
  const apiUrl = 'https://localhost:7284/api/bodegas';
  const [bodegas, setBodegas] = useState([]);
  const [bodegaId, setBodegaId] = useState('');
  const [nombre, setNombre] = useState('');
  const [estado, setEstado] = useState('');
  const [direccion, setDireccion] = useState('');
  const [ciudad, setCiudad] = useState('');
  const [title, setTitle] = useState('');
  const [operation, setOperation] = useState(1);

  useEffect(() => {
    getBodegas();
  }, []);

  const getBodegas = async () => {
    try {
      const response = await axios.get(apiUrl);
      setBodegas(response.data);
    } catch (error) {
      console.error(error);
    }
  };

  const openModal = (
    op,
    id,
    nombre,
    direccion,
    estado,
    ciudad
  ) => {
    setOperation(op);
    setBodegaId(id);

    if (op === 1) {
      setTitle('Registrar bodega');
      setNombre('');
      setEstado('');
      setDireccion('');
      setCiudad('');
    } else if (op === 2) {
      setTitle('Editar bodega');
      setNombre(nombre);
      setEstado(estado);
      setDireccion(direccion);
      setCiudad(ciudad);
    }

    window.setTimeout(function () {
      document.getElementById('nombre').focus();
    }, 500);
  };

  const validar = () => {
    if (nombre.trim() === '') {
      show_alerta('Escribe el nombre de la bodega', 'warning');
    } else if (direccion.trim() === '') {
      show_alerta('Escribe la dirección de la bodega', 'warning');
    } else if (estado.trim() === '') {
      show_alerta('Escribe un estado de la bodega', 'warning');
    } else if (ciudad.trim() === '') {
      show_alerta('Escribe la ciudad de la bodega', 'warning');
    } else {
      const parametros = {
        nombre: nombre,
        direccion: direccion,
        estado: estado,
        ciudad: ciudad,
      };
      const metodo = operation === 1 ? 'POST' : 'PUT';
      enviarSolicitud(metodo, parametros);
    }
  };

  const enviarSolicitud = async (metodo, parametros) => {
    const bodegaIdParam = bodegaId || '';
    try {
      const response = await axios[metodo.toLowerCase()](
        bodegaIdParam ? `${apiUrl}/${bodegaIdParam}` : apiUrl,
        parametros
      );
      const tipo = response.data[0];
      const msj = response.data[1];
      show_alerta(msj, tipo);
      if (tipo === 'success') {
        document.getElementById('btnCerrar').click();
        getBodegas();
      }
    } catch (error) {
      show_alerta('Error de solicitud', 'error');
      console.log(error);
    }
  };

  const deleteBodega = (bodegaId, nombre) => {
    const MySwal = withReactContent(Swal);
    MySwal.fire({
      title: `¿Seguro quieres eliminar el cargo ${nombre}?`,
      icon: 'question',
      text: 'No se podra dar marcha atrás',
      showCancelButton: true,
      confirmButtonText: 'Si, eliminar',
      cancelButtonText: 'Cancelar',
    }).then(async (result) => {
      if (result.isConfirmed) {
        try {
          await axios.delete(`${apiUrl}/${bodegaId}`);
          show_alerta('Usuario eliminado exitosamente', 'success');
          getBodegas();
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
          <div className='col-md-4 offset-md-4'>
            <div className='d-grid mx-auto'>
              <button
                onClick={() => openModal(1)}
                className='btn btn-dark'
                data-bs-toggle='modal'
                data-bs-target='#modalBodegas'
              >
                <i className='fa-solid fa-circle-plus'></i> Añadir
              </button>
            </div>
          </div>
        </div>
        <div className='row mt-3'>
          <div className='col-12 col-lg-8 offset-0 offset-lg-2'>
            <div className='table-responsive'>
              <table className='table table-bordered'>
                <thead>
                  <tr>
                    <th>#</th>
                    <th>Id</th>
                    <th>BODEGA</th>
                    <th>ESTADO</th>
                    <th>DIRECCIÓN</th>
                    <th>CIUDAD</th>
                    <th></th>
                  </tr>
                </thead>
                <tbody className='table-group-divider'>
                  {bodegas.map((bodega, i) => (
                    <tr key={bodega.bodegaId}>
                      <td>{i + 1}</td>
                      <td>{bodega.bodegaId}</td>
                      <td>{bodega.nombre}</td>
                      <td>{bodega.estado}</td>
                      <td>{bodega.direccion}</td>
                      <td>{bodega.ciudad}</td>
                      <td>
                        <button
                          onClick={() => openModal(2, bodega.bodegaId, bodega.nombre, bodega.direccion, bodega.estado, bodega.ciudad)}
                          className='btn btn-warning'
                          data-bs-toggle='modal'
                          data-bs-target='#modalBodegas'
                        >
                          <i className='fa-solid fa-edit'></i>
                        </button>
                        &nbsp;
                        <button
                          onClick={() => deleteBodega(bodega.bodegaId, bodega.nombre)}
                          className='btn btn-danger'
                        >
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
      <div id='modalBodegas' className='modal fade' aria-hidden='true'>
        <div className='modal-dialog'>
          <div className='modal-content'>
            <div className='modal-header'>
              <label className='h5'>{title}</label>
              <button type='button' className='btn-close' data-bs-dismiss='modal' aria-label='Close'></button>
            </div>
            <div className='modal-body'>
              <input type='hidden' id='id' />
              <div className='input-group mb-3'>
                <span className='input-group-text'><i className='fa-solid fa-gift'></i></span>
                <input
                  type='text'
                  id='nombre'
                  className='form-control'
                  placeholder='Nombre'
                  value={nombre}
                  onChange={(e) => setNombre(e.target.value)}
                />
              </div>
              <div className='input-group mb-3'>
                <span className='input-group-text'><i className='fa-solid fa-gift'></i></span>
                <input
                  type='text'
                  id='direccion'
                  className='form-control'
                  placeholder='Dirección'
                  value={direccion}
                  onChange={(e) => setDireccion(e.target.value)}
                />
              </div>
              <div className='input-group mb-3'>
                <span className='input-group-text'><i className='fa-solid fa-gift'></i></span>
                <input
                  type='text'
                  id='estado'
                  className='form-control'
                  placeholder='Estado'
                  value={estado}
                  onChange={(e) => setEstado(e.target.value)}
                />
              </div>
              <div className='input-group mb-3'>
                <span className='input-group-text'><i className='fa-solid fa-gift'></i></span>
                <input
                  type='text'
                  id='ciudad'
                  className='form-control'
                  placeholder='Ciudad'
                  value={ciudad}
                  onChange={(e) => setCiudad(e.target.value)}
                />
              </div>
              <div className='d-grid col-6 mx-auto'>
                <button onClick={() => validar(bodegaId)} className='btn btn-success'>
                  <i className='fa-solid fa-floppy-disk'></i> Guardar
                </button>
              </div>
            </div>
            <div className='modal-footer'>
              <button type='button' id='btnCerrar' className='btn btn-secondary' data-bs-dismiss='modal'>
                Cerrar
              </button>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Bodegas;
