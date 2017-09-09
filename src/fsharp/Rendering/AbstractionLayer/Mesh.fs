// --------------------------------------------------------------------------
//  Copyright (c) 2017 Victor Peter Rouven M�ller
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
// --------------------------------------------------------------------------
namespace Renderer.AbstractionLayer
#nowarn "9"

module Mesh =
    // StdLib imports
    open System
    
    // Engine-modules imports
    open Texture
    open Material

    /// <summary>
    /// Generic Mesh type which defines the minimum amount of information a mesh may contain.
    /// Low Level graphics implementations may use this with additional information (which however isn't required)
    /// </summary>
    [<Struct>]
    type GenericMesh<'Vec3Type, 'Vec2Type> =  {
        Vertices : GenericVertex<'Vec3Type, 'Vec2Type>[]
        Indices : int[]
        TextureReference : TextureReferenceID[]
        MaterialReference : MaterialReferenceID
    }

    type MeshResourcePair<'Attachment, 'Vec3Type, 'Vec2Type> = 
        System.Collections.Generic.KeyValuePair<GenericMesh<'Vec3Type, 'Vec2Type>, 'Attachment>


    let inline createResourcePair mesh attachment =
        MeshResourcePair(mesh, attachment)
    
    type Mesh = GenericMesh<Vec3, Vec2>