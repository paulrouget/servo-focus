/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

// #[link(name = "EGL")]
// #[link(name = "GLESv2")]
// extern {}

#[macro_use]
extern crate log;
extern crate libc;
extern crate servo;

mod api;
mod gl_glue;
mod glue;
mod logs;

pub use api::*;
